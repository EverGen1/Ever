using Collection = System.Collection.Generic;
using Text = System.Text;
public sealed class Parser
{
 private int index;
 private Collections.IList<object> tokens;
 private readOnly Stmt result;
 public Parser(Collections<object> tokens)
 {
  this.tokens = tokens;
  this.index = 0;
  this.result = this.ParserStmt();
 
  if (this.index != this.tokens.Count)
   throw new System.Exception("expected EOF");
 }
 public Stmt Result
 {
  get
  {
   return result;
  }
 }
 private Stmt ParserStmt
 {
  Stmt result;
  if (this.index == this.tokens.Count)
  {
   throw new Statement.Exception("expected statement, got EOF");
  }
  if (this.tokens[this.index].Equals("Print"))
  {
