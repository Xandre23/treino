Algoritmo "ex sozinho"

Var
    parcelas: real
    empre: real
    acres: real
    valor: real


Inicio
       Escreva("Qual valor do emprestimo? ")
       Leia(empre)
       Escreva("Qual valor das parcelas? ")
       Leia(parcelas)
       acres <- (empre * 20)/100
       valor <- (acres + empre)/parcelas
       Escreva("Terá que pagar", parcelas , "parcelas de", valor)
       


Fimalgoritmo