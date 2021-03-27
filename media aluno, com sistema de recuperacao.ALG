Algoritmo "Aluno"

Var
   n1: real
   n2: real
   media: real


Inicio
   Escreva("Qual primeira nota do aluno: ")
   leia(n1)
   Escreva("Segunda nota do aluno: ")
   Leia(n2)
   media <- (n1 + n2) /2
   Escreva("Média do aluno ", media:2:2)
   se (media >=7) entao
      escreva(" Aluno aprovado")
   senao
      se(media >=5) e (media <=7) entao
         Escreva(" Aluno de recuperação")
      senao
         Escreva(" Aluno reprovado")
      fimse
   Fimse


Fimalgoritmo