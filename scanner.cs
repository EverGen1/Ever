using Collection = System.Collections.Generic;
using IO = System.IO;
using text = System.Text;

public sealed class Scanner
{
 private readonly Collection.IList object result;
 public Scanner(IO.TextReader input)
 { 
  this.result = new Collection.List object();
  this.Scan(input);
 }
 public Collection.IList object Tokens
 { 
  get 
   {
    return this.result; 
   }
 } 
 #region ArithmiticConstants 
  public static readonly object Add = new object(); 
  public static readonly object Sub = new object();
  public static readonly object Mul = new object(); 
  public static readonly object Div = new object();
  public static readonly object Semi = new object();
  public static readonly object Equal = new object();
 #endregion
 private void Scan(IO.TextReader input) 
 { 
  while (input.Peek() != -1)
  {
   char ch = (char)input.Peek();
   if (char.IsWhiteSpace(ch)) 
   {
    input.Read();
   } else if (char.IsLetter(ch) || ch == '_') 
   { 
    text.StringBuilder accum = new text.StringBuilder();
    while (char.IsLetter(ch) || ch == '_')
    {
     accum.Append(ch); input.Read();
     if (input.Peek() == -1) { break;
    } 
    else
    {
     ch = (char)input.Peek();
    } 
   } 
   this.result.Add(accum.ToString());
  } else if (ch == '"')
  {
   text.StringBuilder accum = new text.StringBuilder();
   input.Read();
   if (input.Peek() == -1)
   { 
    throw new System.Exception("unterminated string literal"); 
   } 
   while ((ch = (char)input.Peek()) != '"')
   {
    accum.Append(ch); 
    input.Read(); 
    if (input.Peek() == -1)
    {
     throw new System.Exception("unterminated string literal");
    }
   }
   input.Read(); this.result.Add(accum);
  } 
  else if (char.IsDigit(ch))
  { 
   text.StringBuilder accum = new text.StringBuilder();
   while (char.IsDigit(ch))
   { 
    accum.Append(ch);
    input.Read(); 
    if (input.Peek() == -1)
    { 
     break;
    }
    else 
    {
     ch = (char)input.Peek();
    }
   }
   this.result.Add(int.Parse(accum.ToString­())); 
  } 
  else switch (ch) 
  {
   case '+': 
    input.Read();
    this.result.Add(Scanner.Add); 
    break;
   case '-':
    input.Read(); 
    this.result.Add(Scanner.Sub);
    break; 
   case '*': 
    input.Read();
    this.result.Add(Scanner.Mul); 
    break;
   case '/':
    input.Read();
    this.result.Add(Scanner.Div);
    break;
   case '=':
    input.Read();
    this.result.Add(Scanner.Equal); 
    break;
   case ';':
    input.Read();
    this.result.Add(Scanner.Semi);
    break;
   }
  }
 }
}
