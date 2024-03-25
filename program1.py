import math
from sympy import *

def mean():
	mylist = []
	k = int(input("Numero de dados: "))
	for i in range(k):
		n = float(input("Dado: "))
		n1 = mylist.append(n)
	d = sum(mylist)
	mean = d/k
	print("Media: " , mean)
	print()

def main():
	while True:
		print("Qual tarefa voce quer?")
		print("Escreva sair ou quit para encerrar")
		print("	1) Tirar Media")
		print("	2) Resultado experimento")
		print("	3) Derivada parcial")
		a = input()
		if a == "sair" or a == "quit" or a == "q" or a == "qqq":
			break
		if a == "1" or a == "1)":
			print()
			mean()
		elif a == "2" or a == "2)":
			print()
			lab()
		elif a == "3" or a == "3)":
			print()
			print("Funcao ainda nao implementada")
			print()
		else:
			print()
			print("Entrada invalida")
			print()

def lab():
	mylist3 = []
	k = int(input("Numero de dados: "))
	for i in range(k):
		n = float(input("Dado: "))
		n1 = mylist3.append(n)
	d = sum(mylist3)
	mean = d/k
	mylist4 = []
	for j in range(k):
		f = mean - mylist3[j]
		f1 = f ** 2
		g = mylist4.append(f1)
	h = sum(mylist4)
	l = h/(k-1)
	stndrd = math.sqrt(l)
	ua = stndrd/math.sqrt(k)
	print("Media:" , mean)
	print("Desvio Padrao:", stndrd)
	print("Incerteza tipo a:", ua)
	ub = float(input("Escreva incerteza tipo b: "))
	uc = math.sqrt((ua)**2 + (ub)**2)
	print("Incerteza tipo c: ", uc)
	ur = (uc/mean) * 100
	urr = str(ur) + "%"
	print("Incerteza relativa: ", urr)
	print()
	while True:
		print("Calcular erro? S/N")
		question = input()
		if question == "S" or question == "s":
			og = float(input("Escrever valor original: "))
			ae = og - mean
			re = (ae/og) * 100
			re1 = str(re) + "%"
			print("Erro absoluto: ", ae)
			print("Erro relativo: ", re1)
			break
		elif question == "N" or question == "n":
			break
		else:
			print("Entrada invalida")
			print()
	print()		

main()