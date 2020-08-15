grammar Math;

compileUnit
    :   expression EOF # expressionCompileUnit
    |   equation EOF   # equationCompileUnit
    ;

equation
    :   left = expression '=' right = expression
    ;

expression
    :   parenthesesExpression                                  # parentheses
    |   func = functionName '(' expression ')'                 # function
    |   op = ('+'|'-') expression                              # unary
    |   left = expression op = '^'       right = expression    # power
    |   multiplicationExpression                               # multiplicationNoAsterisk
    |   left = expression '*' right = expression               # multiplication
    |   left = expression '/' right = expression               # division
    |   left = expression '+' right = expression               # addition
    |   left = expression '-' right = expression               # subtraction
    |   numberExpression                                       # number
    |   variableExpression                                     # variable
    ;

functionName
    :   'sqrt'
    |   'exp'
    ;

parenthesesExpression
    :   '(' expression ')'
    ;

multiplicationExpression
    :   leftParenExpr = parenthesesExpression rightParenExpr = parenthesesExpression   # doubleParentheses
    |   leftNum = numberExpression rightVar = variableExpression                       # numberVariable
    |   leftVar = variableExpression rightVar = variableExpression                     # variableVariable
    |   leftVar = variableExpression rightNum = numberExpression                       # variableNumber
    |   leftNum = numberExpression rightParenExpr = parenthesesExpression              # numberParentheses
    |   leftVar = variableExpression rightParenExpr = parenthesesExpression            # variableParentheses
    |   leftParenExpr = parenthesesExpression rightNum = numberExpression              # parenthesesNumber
    |   leftParenExpr = parenthesesExpression rightVar = variableExpression            # parenthesesVariable
    |   leftMulExpr = multiplicationExpression rightParenExpr = parenthesesExpression  # multiplicationParentheses
    |   rightParenExpr = parenthesesExpression leftMulExpr = multiplicationExpression  # parenthesesMultiplication
    |   rightVar = variableExpression leftMulExpr = multiplicationExpression           # variableMultiplication
    |   leftMulExpr = multiplicationExpression rightVar = variableExpression           # multiplicationVariable
    ;

numberExpression
    : value = NUM
    ;

variableExpression
    : value = VAR
    ;

OP_ADD: '+';
OP_SUB: '-';
OP_MUL: '*';
OP_DIV: '/';
OP_POW: '^';

VAR :   [a-zA-Z];
NUM :   [0-9]+ ('.' [0-9]+)? ([eE] [+-]? [0-9]+)?;
WS  :   [ \t\r\n] -> channel(HIDDEN);