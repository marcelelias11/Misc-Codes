v0 = rand() // Velocidade Inicial
a = rand() // Aceleração
p = poly([v0 a], "t", "coeff") // Função horária da velocidade
bt = 0:rand():10 // Conserta um bug. Não remover.
t = 0:rand():10 // Tempo aleatório
vt = v0 + (a*t) // Resultado da função horária
t2 = 2*rand() // Tempo aleatório 2
vt0 = v0 + (a*0) // Função 1 da regra de Simpson
vt1 = v0 + (a*((0+t2)/2)) // Função 2 da regra de Simpson
vt2 = v0 + (a*t2) // Função 3 da regra de Simpson
Ivt = ((t2-0)/6)*(vt0 + 4*vt1 + vt2) // Integração por regra de Simpson
I = integrate(string(vt), "t", 0, t2) // Integração por Scilab
dif = abs(I-Ivt) // Diferença de resultados da integração
disp("1. v0 = "+ string(v0)) //Resposta da 1a questão
disp("2. a = "+ string(a)) //Resposta da 2a questão
disp("3. v(t) = v0 + at" + ascii(10) + "      v(t) = " + string(p)) //Equação da função horária + Resposta da 3a questão
disp("4. t = " + string(t)) //Resposta da 4a questão
disp("5. v(t) = " + string(vt)) //Resposta da 5a questão
disp("8. t2 = " + string(t2)) //Resposta da 8a questão
disp("9. Integral = " + string(Ivt)) //Resposta da 9a questão
disp("10. Integral Scilab = " + string(I)) //Resposta da 10a questão
disp("11. Diferença entre Integrais: " + string(dif)) //Resposta da 11a questão
plot2d("nn",t,vt) //Resposta da 6a questão
xtitle("Velocidade x Tempo", "Tempo(s)", "Velocidade(m/s)") //Resposta da 7a questão
