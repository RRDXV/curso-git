{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1046{\fonttbl{\f0\fnil Cascadia Mono;}{\f1\fnil\fcharset0 Cascadia Mono;}{\f2\fnil\fcharset0 Calibri;}}
{\colortbl ;\red0\green128\blue0;\red0\green0\blue255;\red0\green0\blue0;\red163\green21\blue21;\red43\green145\blue175;}
{\*\generator Riched20 10.0.19041}\viewkind4\uc1 
\pard\sa200\sl276\slmult1\cf1\f0\fs19\lang22 /*\par
            Console.WriteLine("Escreva seu nome: ");\par
            String nome = Console.ReadLine();\par
            Console.WriteLine("Seu nome \f1\'e9: ");\par
            Console.WriteLine(nome); */\par
\par
\cf2\lang1046\tab\tab\f0\lang22 int\cf3  n = 20 + 60 + 90;\par
            \cf2 int\cf3  b = 10 * 90;\par
            \cf2 float\cf3  d = 5.0f / 2.0f;\par
            \cf2 int\cf3  teste = 2 + (3 * 10) + 4 + 10;\par
\par
            Console.WriteLine(n);\par
            Console.WriteLine(b);\par
            Console.WriteLine(d);\par
            Console.WriteLine(teste);\par
\f1\lang1046 ///////////////////////////////////////////////////////////////////////////////\par
\cf2\tab\tab\f0 if\cf3  (10 > 12)\par
            \{\par
                Console.WriteLine(\cf4 "\f1\'c9 verdade!"\cf3 );\par
            \}\par
            \cf2 else\cf3  \cf2 if\cf3  (20 == 20)\par
            \{\par
                Console.WriteLine(\cf4 "Executou Else If"\cf3 );\par
            \}     \par
            \cf2 else\cf3\par
            \{\par
                Console.WriteLine(\cf4 "\'c9 mentira"\cf3 );\par
            \}\par
\cf0\f2\fs22\lang22 ************************************************************************************\par
\cf3\f0\fs19  \cf2 static\cf3  \cf2 void\cf3  Main(\cf2 string\cf3 [] args)\par
        \{\par
            Console.WriteLine(\cf4 "Digite a sua idade: "\cf3 );\par
\par
            \cf2 int\cf3  a = \cf2 int\cf3 .Parse(Console.ReadLine());\par
\par
            \cf2 if\cf3  (a >= 0 && a <= 11)\par
            \{\par
                Console.WriteLine(\cf4 "Voc\f1\'ea \'e9 uma crian\'e7a!"\cf3 );\par
            \}\par
            \cf2 else\cf3  \cf2 if\cf3  (a >= 12 && a <= 17)\par
            \{\par
                Console.WriteLine(\cf4 "Voc\'ea \'e9 um Adolecente!"\cf3 );\par
            \}\par
            \cf2 else\cf3  \cf2 if\cf3  (a >= 18 && a <= 99)\par
            \{\par
                Console.WriteLine(\cf4 "Voc\'ea \'e9 um Adulto!"\cf3 );\par
            \}  \par
            \par
            Console.ReadLine();\par
**************************************************************************\par
\cf2\f0 internal\cf3  \cf2 class\cf3  \cf5 Program\cf3\par
    \{\par
        \cf2 static\cf3  \cf2 void\cf3  Main(\cf2 string\cf3 [] args)\par
        \{\par
            Console.WriteLine(\cf4 "Tabela de pre\f1\'e7os"\cf3 );\par
           \par
            pf (\cf4 "Chocolate"\cf3 , 30);\par
            pf (\cf4 "refrigerante"\cf3 , 50);\par
            pf (\cf4 "bolo"\cf3 , 45);\par
            pf (\cf4 "sorvete"\cf3 , 60);\par
            pf (\cf4 "p\'e3o"\cf3 , 15);\par
            msg();\par
\par
            \cf2 float\cf3  ra = pizza(30);\par
            Console.WriteLine(\cf4 "A area da Pizza deve ser aproximadamente de: "\cf3  + ra + \cf4 " CM"\cf3 );\par
\par
            msg();\par
\par
            \cf2 float\cf3  re = praca(250, 350);\par
            Console.WriteLine(\cf4 "A area do terreno \'e9 de aproximadamente: "\cf3  + re + \cf4 " m\'b2"\cf3 );\par
\par
            \par
            Console.ReadLine();\par
        \}\par
\par
        \cf2 static\cf3  \cf2 void\cf3  msg()\par
        \{\par
            Console.WriteLine(\cf4 "--------------------------------------------------------------"\cf3 );\par
            Console.WriteLine(\cf4 "--------------------------------------------------------------"\cf3 );\par
        \}\par
\par
        \cf2 static\cf3  \cf2 void\cf3  pf(\cf2 string\cf3  nome, \cf2 int\cf3  preco)\par
        \{\par
            \cf2 int\cf3  vf = preco + (preco/4);\par
            Console.WriteLine(\cf4 "O produto: "\cf3  + nome + \cf4 " est\'e1 custando R$"\cf3  + vf);\par
        \}\par
\par
        \cf2 static\cf3  \cf2 float\cf3  pizza (\cf2 int\cf3  raio)\par
        \{\par
            \cf2 float\cf3  pi = 3.14f;\par
            \cf2 float\cf3  area = pi * (raio * raio);\par
            \cf2 return\cf3  area;\par
        \}\par
\par
        \cf2 static\cf3  \cf2 int\cf3  praca (\cf2 int\cf3  Base, \cf2 int\cf3  Altura)\par
        \{\par
            \cf2 int\cf3  area = (Base * Altura) / 2;\par
            \cf2 return\cf3  area;\par
        \}\par
\par
    \}\par
\par
******************************************************************************\par
\par
1 - String\par
2 - Float, Double\par
3 - Char\par
4 - Bool\par
5 - I- string, II- int , III- float , IV- char, V- bool.\par
\par
gabariteiiiiiiiii\par
\par
\par
  // int - inteiro, armazenar numeros inteiros neg ou pos\par
            // float - ele pode ser um numero pos ou neg, s\'f3 que ele \'e9 quebrado\par
            // Double e decimal\par
            // bool - s\'b4pode ter dois dados, verdadeiro ou falso\par
            // string - "" ele \'e9 indentificado por aspas, \'e9 um tipo texto\par
            // char - 'a' \'e9 so um caracter que pode ser colocado, no caso caracter\par
\par
            // o caracter tem que ter letras de A-Z, Numeros 0-9, @ $ .,\par
            // n\'e3o pode criar com a palavra class ou using e static, s\'e3o palavras reservadas\par
\par
            /*  oi\par
            \par
            int ano = 1942;\par
            string cor = "vermelho";\par
            float velocidade = 294.48f; // sempre coloque a letra "f" no final do numero\par
            bool anoocorrido = true;\par
\par
            Console.WriteLine(ano);\par
            Console.WriteLine(cor);\par
            Console.WriteLine(velocidade);\par
            Console.WriteLine(anoocorrido);\par
\par
            velocidade = 348.29f;\par
\par
            Console.WriteLine(velocidade);*/\par
\par
            /* var cor = "vermelho";\par
            var modelo = 2356;\par
            */\par
\par
const float PI = 3.145687f; // \'e9 uma fun\'e7\'e3o que usa para manter uma funcionalidade fixa - \'e9 uma alternativa\cf0\f2\fs22\par
}
 