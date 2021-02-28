#algotimo de Floyd.
#Dado o grafo abaixo, concluir o cálculo do caminho mínimo entre os pares i e j usando o algoritmo.
#de Floyd e recuperar todas as trajetórias do caminho mínimo .
#para cada i e j apresentando as matrizes finais de distância e predecessor. 


__author__ = "Fernando Andrade"

#Para colocar em prática criaremos um função e passamos 1 parâmentro que servirá para ser o ponto de partida.
def acharDuplicatos(numeros):   

    #Aqui criaremos 2 variáveis, para que possam percorrer a lista.

    tartaruga = numeros[0]
    lebre = numeros[0]


    #Iniciaremos um loop para dar inicio.    
    while True:

        
        #damos inicio oara que as duas variáveis percorram a lista em tempos diferentes, dentro da lista. 
        
        tartaruga = numeros[tartaruga]
        lebre = numeros[lebre]

        #Tenha em mente que duas variáveis estão pecorrendo em instâncias diferentes, o que significa que um está na frente 
        #e outro atrás, quando ambos encontrarem o mesmo valor dentro da lista, será o momento que o loop irá finalizar.

        if tartaruga == lebre:
            break

    partida1 = numeros[0]
    partida2 = tartaruga

    #Nessa parte declaramos que enquanto os números forem diferentes eles irão percorrer a lista
    while partida1 != partida2:
        partida1 = numeros[partida1]
        partida2 = numeros[partida2] 

    #Aqui é onde retorna o primeiro valor duplicado.
    return partida1

print('')
print("Número duplicato encontrado foi...",acharDuplicatos([1,3,2,3,4,5]))
print('')