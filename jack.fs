\ Copyright (c) 2009 Marcus Eskilsson. All rights reserved.

\ Redistribution and use in source and binary forms, with or without
\ modification, are permitted provided that the following conditions
\ are met:
\ 1. Redistributions of source code must retain the above copyright
\    notice, this list of conditions and the following disclaimer.
\ 2. Redistributions in binary form must reproduce the above copyright
\    notice, this list of conditions and the following disclaimer in the
\    documentation and/or other materials provided with the distribution.

\ THIS SOFTWARE IS PROVIDED BY AUTHOR AND CONTRIBUTORS ``AS IS'' AND
\ ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
\ IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
\ ARE DISCLAIMED.  IN NO EVENT SHALL AUTHOR OR CONTRIBUTORS BE LIABLE
\ FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
\ DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS
\ OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
\ HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT
\ LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY
\ OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF
\ SUCH DAMAGE.

s" jack" add-lib
\c #include <jack/jack.h>

\ See jack API documentation.
c-function jack-client-open jack_client_open a n a -- a
	\ TODO This baby takes optional arguments. To be added later.
c-function jack-set-process-callback jack_set_process_callback a a n -- n

c-function jack-port-get-buffer jack_port_get_buffer a n -- a
		\ void* -- jack_port_t* jack_nframes_t
c-function jack-on-shutdown a a a -- void
		\ jack_client_t* void(*)(void *arg) void * -- void
c-function jack-get-sample-rate jack_get_sample_rate a -- n
		\ jack_client_t* -- jack_nframes_t
c-function jack-port-register jack_port_register a a a n n -- a
		\ jack_client_t* char* char* ulong ulong -- jack_port_t*
c-function jack-activate jack_activate a -- n
		\ jack_client_t* -- int

include jack-types.fs

