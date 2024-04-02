all:				proj4_release proj4_dbg
.PHONY:				all
proj4_release:		proj4.c
					gcc -o proj4 proj4.o proj4.c

proj4_dbg:		 	proj4.s
					gcc -g -o proj4 proj4.o proj4.c
.PHONY:				clean
clean:
					rm proj4_release
					rm proj4_dbg