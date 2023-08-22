//using Extreme.Mathematics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Calculator
{
    class Calculator
    {
        
        public readonly string[] DIGITS = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public readonly string[] OPERATORS = { "+", "-", "×", "÷"};
        public readonly string[] PARANTHESIS = { "(", ")" };  
        private readonly Dictionary<string, (string symbol, int predence, bool rightAssociative)> operators =
            new (string symbol, int predence, bool rightAssociative)[] {
                ("×", 3, false),
                ("÷", 3, false),
                ("+", 2, false),
                ("-", 2, false)
            }.ToDictionary(op => op.symbol);
        public static readonly decimal PI = 3.1415926535897932384626M;

        Base.History _history;

        public DynamicText number { get; set; }
        public DynamicText expressions { get; set; }
        public int paranthesisInExpressionCount{ get; set; }
        
        public Calculator(DynamicText number,DynamicText expression, Base.History history) {
            this.number=number;
            this.expressions=expression;
            _history = history;
        }

        public string EvaluateTheExpression(string infixExpression) {
            var postfix = InfixToPostfix(infixExpression);
            var result = EvaluatePostix(postfix);

            _history.Add("Nebenrechnung", $"{result} = {infixExpression}");

            return result;
        }

        // shunting-yard algoritması tablomuz aracılığıyla infix ifadeyi
        //  postfix hale çeviriyor.
        private List<string> InfixToPostfix(string infix) {
            string[] tokens = infix.Split(' ');
            Stack<string> stack = new Stack<string>();
            List<string> postfix = new List<string>();
            foreach(string token in tokens) {
                if(Decimal.TryParse(token, out _)) {
                    postfix.Add(token);
                } else if(operators.TryGetValue(token, out var op1)) {
                    while(stack.Count > 0 && operators.TryGetValue(stack.Peek(), out var op2)){
                        int c = op1.predence.CompareTo(op2.predence);
                        if(c < 0 || !op1.rightAssociative && c<=0) {
                            postfix.Add(stack.Pop());
                        } else {
                            break;
                        }
                    }
                    stack.Push(token);
                } else if(token=="(") {
                    stack.Push("(");
                } else if(token ==")") {
                    while(stack.Count > 0 && stack.Peek() != "(") {
                        postfix.Add(stack.Pop());
                    }
                    postfix.Add(stack.Pop());
                }
            }
            while(stack.Count >0) {
                postfix.Add(stack.Pop());
            }
            foreach(string s in postfix) {
                Debug.Write(s+" ");
            }
            Debug.WriteLine("");
            return postfix;   
        }

        // postfix ifadeyi hesaplıyor. (Reverse-Polish Notation)
        private string EvaluatePostix(List<string> postfix) {
            decimal temp,topStack, retVal=0;
            var stack = new Stack<string>();
            foreach(string s in postfix) {
                if(Decimal.TryParse(s,out _)) {
                    stack.Push(s);
                } else if(operators.TryGetValue(s,out var op)) {
                    Decimal.TryParse(stack.Pop(), out topStack);
                    Decimal.TryParse(stack.Pop(), out temp);
                    switch(s) {
                        case "+":
                            retVal=Decimal.Add(temp, topStack);
                            break;
                        case "-":
                            retVal=Decimal.Subtract(temp, topStack);
                            break;
                        case "÷":
                            retVal=Decimal.Divide(temp, topStack);
                            break;
                        case "×":
                            retVal=Decimal.Multiply(temp, topStack);
                            break;
                        default:
                            retVal=-987656789;
                            break;
                    }
                    stack.Push(retVal.ToString());
                }
            }
            return stack.Pop();
        }
    }
}
