import string

codeABC = list(string.ascii_lowercase)

def ReplaceLetters(a,b):
	a, b = codeABC.index(a), codeABC.index(b)
	codeABC[a], codeABC[b] = codeABC[b], codeABC[a]
	return codeABC

def Shift_n_letters(letter, n):
    return chr((ord(letter) - 97 + n % 26) % 26 + 97)

def ShiftN(shift):
	for i in range(len(codeABC)):
		codeABC[i]=Shift_n_letters(codeABC[i],shift)
	return codeABC

def isIt(message):
    return str(message).find("this")!=-1

def translte(message):
    message=list(message)
    for i in range(len(message)):
        message[i]=codeABC[ord(message[i])-ord(a)]
