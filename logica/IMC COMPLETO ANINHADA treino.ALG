Algoritmo "IMC COMPLETO aninhada"

Var
   peso: real
   altura: real
   imc: real


Inicio
   Escreva("Qual seu peso? ")
   Leia(peso)
   Escreva("Qual sua altura? ")
   leia(altura)
   imc <- peso / (altura ^ 2)
   escreva("IMC:", imc:5:2)
   se(imc < 17) entao
      escreva(" Muito abaixo do peso")
   senao
      se(imc > 17) e (imc <= 18.5) entao
         escrevaL(" Você está abaixo do peso")
      senao
         se(imc >= 18.5) e (imc < 25) entao
            escrevaL(" peso ideal")
         senao
            se(imc >= 25) e (imc <=30) entao
               EscrevaL(" Sobrepeso")
            senao
               se(imc >= 30 ) e (imc < 35)entao
                  EscrevaL(" Obesidade")
               senao
                  se(imc >= 35) e (imc < 40) entao
                     EscrevaL(" Obesidade severa")
                  senao
                     EscrevaL(" Obesidade morbida")
                  fimse
               fimse
            fimse
         fimse
      fimse
   fimse


Fimalgoritmo