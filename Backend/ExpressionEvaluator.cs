
namespace Backend;

public static class ExpressionEvaluator
{
    public static double Evalute(string infix) => EvalutePostfix(ToPostfix(infix));
    private static string ToPostfix(string infix)
    {
        var postfix = string.Empty;
        var stack = new Stack<char>();
        for (int i = 0; i < infix.Length; i++)
        {
            char item = infix[i];
            if (char.IsDigit(item) || item == '.')
            {
                string number = string.Empty;
                while (i < infix.Length && (char.IsDigit(infix[i]) || infix[i] == '.'))
                {
                    number += infix[i];
                    i++;
                }
                i--;
                postfix += number + " ";
            }
            else if (char.IsWhiteSpace(item))
            {
            //Ignorar espacios
            }
            else if (item == '(')
            {
                stack.Push(item);
            }
            else if (item == ')')
            {
                while (stack.Count > 0 && stack.Peek() != '(')
                {
                    postfix += stack.Pop().ToString() + " ";
                }
                if (stack.Count == 0)
                    throw new Exception("Paréntesis desbalanceados.");
                    stack.Pop();
            }
            else if (IsOperator(item))
            {
                while (stack.Count > 0 && stack.Peek() != '(' && (PriorityStack(stack.Peek()) > PriorityInfix(item) ||
                       (PriorityStack(stack.Peek()) == PriorityInfix(item) && item != '^')))
                {
                    postfix += stack.Pop().ToString() + " ";
                }
                stack.Push(item);
            }
            else
            {
                throw new Exception("Expresión inválida.");
            }
        }
        while (stack.Count > 0)
        {
            char op = stack.Pop();
            if (op == '(')
                throw new Exception("Paréntesis desbalanceados.");
                postfix += op.ToString() + " ";
        }
        return postfix.Trim();
    }
    private static int PriorityStack(char op) => op switch
    {
        '^' => 3,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 0,
        _ => throw new Exception("Operador inválido.")
    };
    private static int PriorityInfix(char op) => op switch
    {
        '^' => 3,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        _ => throw new Exception("Operador inválido.")
    };
    private static bool IsOperator(char item) => item == '^' || item == '*' || item == '/' || item == '+' || item == '-';
    private static double EvalutePostfix(string postfix)
    {
        var stack = new Stack<double>();
        var tokens = postfix.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (var token in tokens)
        {
            if (token.Length == 1 && IsOperator(token[0]))
            {
                if (stack.Count < 2)
                    throw new Exception("Expresión inválida.");
                    double ope2 = stack.Pop();
                    double ope1 = stack.Pop();
                    stack.Push(Calculate(ope1, ope2, token[0]));
            }
            else
            {
                if (!double.TryParse(token, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture,
                    out double number))
                {
                    throw new Exception("Número invalido.");
                }
                stack.Push(number);
            }
        }
        if (stack.Count != 1)
            throw new Exception("Expresión inválida.");
        return stack.Pop();
    }
    private static double Calculate(double ope1, double ope2, char item) => item switch
    {
        '*' => ope1 * ope2,
        '/' => ope1 / ope2,
        '+' => ope1 + ope2,
        '-' => ope1 - ope2,
        '^' => Math.Pow(ope1, ope2),
        _ => throw new Exception("Operador inválido.")
    };
}
