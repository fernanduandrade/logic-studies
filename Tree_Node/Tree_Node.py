__author__ = "Fernando Andrade"
__copyright__ = "Copyright 2020"

#Representação de Nodo em python
class NodoArvore:
	def __init__(self, chave=None, esquerda=None, direita=None):
		self.chave = chave
		self.esquerda = esquerda
		self.direita = direita

	def __repr__(self):
		return '%s <- %s -> %s' % (self.esquerda and self.esquerda.chave,
									self.chave,
									self.direita and self.direita.chave)

def em_ordem(raiz):
	if not raiz:
		return

	em_ordem(raiz.esquerda)
	print(raiz.chave)
	em_ordem(raiz.direita)


raiz = NodoArvore(40)

raiz.esquerda = NodoArvore(20)
raiz.direita = NodoArvore(60)

raiz.direita.esquerda = NodoArvore(50)
raiz.direita.direita = NodoArvore(70)
raiz.esquerda.esquerda = NodoArvore(10)
raiz.esquerda.direita = NodoArvore(30)

#A representação do output é que no meio é o nodo pai, enquanto o da esquerda e direita
#São os filhos.

print("Árvore: ",raiz)

#Nodo corrente
em_ordem(raiz)