Algoritmo "TRIANGULOS"

Var
  l1, l2, l3: real
  eq, es, tri: logico
Inicio
  Escreva("digite o primeiro lado: ")
  leia(l1)
  escreva("Digite o segundo lado: ")
  leia(l2)
  escreva("Digite o terceiro lado: ")
  leia(l3)
  tri <- (l1 < l2 + l3)   e (l2 < l1 + l3) e (l3 < l1 + l2)
  eq <- (l1 = l2) e (l2 = l3)
  es <- (l1 <> l2) e (l2 <> l3) e (l1 <> l3)
  escreval("Pode formar um triangulo?", tri)
  escreval("o triangulo é equilatero?", eq)
  escreva("o triangulo é escaleno", es)



Fimalgoritmo