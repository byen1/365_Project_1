all: run	

clean: 
	rm -f proj1.exe

proj1.exe: *.cs
	mcs -o proj1.exe *.cs

run: proj1.exe
	mono proj1.exe test.asm
