#include <iostream>

#define numCoins 5;
#define numNotes 6;

void foundCoins(double value, int* coins, int* qtd);
void foundNotes(double value,int* notes, int* qtd);

int main(){
    double value = 0;
    int coins = 0;
    int notes = 0;

    //std::vector<double> coins = {0.05, 0.1, 0.25, 0,5, 1.00};
    int coins[] = {5, 10, 25, 50, 100};
    int notes[] = {2, 5, 10, 20, 50, 100};
    int qtdCoins[numCoins];
    int qtdNotes[numNotes];

    scanf("%f",&value);

    notes = (100*value - (100*value)%100)/100;
    coins = (value - notes);

    foundCoins(coins*100, coins, qtdCoins);
    foundBanks(notes, notes, qtdNotes);

}

int sumVector(int* vector){
    int sum = 0;
    int i=0;

    while((vector+i) != null){
        sum += *(vector + i);
        ++i;
    }

    return sum;
}

void copyVector(int* orig, int* copy){;
    int i=0;

    while((orig + i) != null && (copy + i) != null){
        *(copy + i) = *(orig + i)
        ++i;
    }

    return sum;
}

void foundCoins(double value, int* coins, int* qtd){
    int auxQtd[numCoins];
    *(qtd) = value;
    for(int i = 1; i < numCoins, ++i){
        while(value-(*(qtd+i)+1) * *(coins+i) > 0){
            foundCoins(value-(*(qtd+i)+1) * *(coins+i), coins, auxQtd);
            if(sumVector(auxQtd) < sumVector(qtd))
                copyVector(auxQtd, qtd);
            else
                break;
        }
    }
}
void foundBanks(double value, int* notes, int* qtd){
    int auxQtd[numNotes];
    *(qtd) = value;
    for(int i = 1; i < numNotes, ++i){
        while(value-(*(qtd+i)+1) * *(notes+i) > 0){
            foundCoins(value-(*(qtd+i)+1) * *(notes+i), notes, auxQtd);
            if(sumVector(auxQtd) < sumVector(qtd))
                copyVector(auxQtd, qtd);
            else
                break;
        }
    }
}

void printMessage(int* coins, int* notes, int* qtdCoins, int* qtdNotes){
    printf("Notas:")
    for(int i = 0; i < numNotes; i++){
        printf("%d")
    }
    printf("MOEDAS:")
    for(int i = 0; i < numCoins; i++){
        printf("%.2f")
    }
}