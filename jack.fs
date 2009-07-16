s" jack" add-lib
\c #include <jack/jack.h>

c-function jack-client-open jack_client_open a n a -- a
	\ TODO This baby takes optional arguments. To be added later.

0x00	constant	JackNullOption
0x01	constant	JackNoStartServer
0x02	constant	JackUseExactName
0x04	constant	JackServerName
0x08	constant	JackLoadName
0x10	constant	JackLoadInit

: null-terminate  ( u c-addr -- )
	+ 0 swap c!
;
: jack-client-name
	\ TODO Add some error checking for allocate.
	create ( c-addr u -- )  dup 1+ allocate drop dup , 
							2dup null-terminate
							swap move
	does>  ( -- a ) @
; 
