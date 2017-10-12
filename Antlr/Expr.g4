grammar Expr;

/*
 * Parser Rules
 */

text
	: sentence*	EOF
	;

sentence
	: (word SPACE*)+ END_CHAR
	;

word
	: simple_word |
	  number;

simple_word
	: LETTER+;
number
	: DIGIT+;

/*
 * Lexer Rules
 */

END_CHAR
	: '.' | '?' | '!';

SPACE
	:	' ';

NEW_LINE
	: '\n' | '\r\n';
DIGIT
	: '1..9';

LETTER
	:  .;




