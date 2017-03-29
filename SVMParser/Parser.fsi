// Signature file for parser generated by fsyacc
module Parser
type token = 
  | EOF
  | NEWLINE
  | LSQBRACKET
  | RSQBRACKET
  | LABELDEF
  | COLON
  | END
  | ID of (string * (int * int))
  | JEQ of (int * int)
  | JC of (int * int)
  | JMP of (int * int)
  | CMP of (int * int)
  | DIV of (int * int)
  | MUL of (int * int)
  | SUB of (int * int)
  | ADD of (int * int)
  | MOD of (int * int)
  | NOT of (int * int)
  | OR of (int * int)
  | AND of (int * int)
  | MOV of (int * int)
  | NOP of (int * int)
  | REG4 of (int * int)
  | REG3 of (int * int)
  | REG2 of (int * int)
  | REG1 of (int * int)
  | STRING of (string * (int * int))
  | FLOAT of (float * (int * int))
  | INT of (int * (int * int))
type tokenId = 
    | TOKEN_EOF
    | TOKEN_NEWLINE
    | TOKEN_LSQBRACKET
    | TOKEN_RSQBRACKET
    | TOKEN_LABELDEF
    | TOKEN_COLON
    | TOKEN_END
    | TOKEN_ID
    | TOKEN_JEQ
    | TOKEN_JC
    | TOKEN_JMP
    | TOKEN_CMP
    | TOKEN_DIV
    | TOKEN_MUL
    | TOKEN_SUB
    | TOKEN_ADD
    | TOKEN_MOD
    | TOKEN_NOT
    | TOKEN_OR
    | TOKEN_AND
    | TOKEN_MOV
    | TOKEN_NOP
    | TOKEN_REG4
    | TOKEN_REG3
    | TOKEN_REG2
    | TOKEN_REG1
    | TOKEN_STRING
    | TOKEN_FLOAT
    | TOKEN_INT
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startstart
    | NONTERM_start
    | NONTERM_newlineSeq
    | NONTERM_program
    | NONTERM_register
    | NONTERM_literal
    | NONTERM_address
    | NONTERM_adressOrReg
    | NONTERM_anyBinaryOpErr
    | NONTERM_anyOpErr
    | NONTERM_instruction
    | NONTERM_newlineOpt
    | NONTERM_instructionSeq
/// This function maps tokens to integer indexes
val tagOfToken: token -> int

/// This function maps integer indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val start : (Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> (SVMAST.Program) 
