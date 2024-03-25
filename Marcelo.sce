lambda = 5.78*(10^-4); //Constante de decaimento do Carbono-11
freeman = 0.693 / lambda //Valor da meia vida
n0 = 1000*rand() //Número inicial aleatório
t = 100*rand() //Tempo inicial aleatório
nt = n0 * %e ^ (-1 * lambda * t) // Número após um período t
dt = 0:rand():100 //Intervalo de tempo aleatório
ndt = n0 * %e ^ (-1 * lambda * dt) // Número durante o intervalo "dt"
disp("a) T1/2 = " + string(freeman)) //Resposta da letra a
disp("b) N0 = " + string(n0)) //Resposta da letra b
disp("c) N(t) = " + string(nt)) //Resposta da letra c
disp("d) N(dt) = " + string(ndt)) //Resposta da letra d
plot2d("nn",dt,ndt) //Resposta da letra e
