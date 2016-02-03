grammar CSV;

/*
 * Parser Rules
 */

file : hdr row+ ;
hdr : row ;

row : field (',' field)* '\r'? '\n' ;

field
    :   TEXT	# text
    |   STRING	# string
    |		# empty
    ;

/*
 * Lexer Rules
 */

TEXT : ~[,\n\r"]+ ;
STRING : '"' ('""'|~'"')* '"' ;
WS	:	' ' -> channel(HIDDEN)
	;
