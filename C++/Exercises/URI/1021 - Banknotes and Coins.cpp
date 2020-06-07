#include<iostream>
#include<cmath>
#include<vector>
#include<iomanip>

double changeNotes(double money, double value);
double changeCoins(double money, double value);

int main(){
	double value;
	int money; 
	std::vector<double> notes = {10000, 5000, 2000, 1000, 500, 200};
	std::vector<double> coins = {100, 50, 25, 10, 5};

	std::cin >> value;
	money = value*100;

	std::cout << "NOTAS:"<< std::endl;

	for (std::vector<double>::iterator i = notes.begin(); i != notes.end(); ++i)
		money = changeNotes(money,*i);

	std::cout << "MOEDAS" << std::endl;

	for (std::vector<double>::iterator i = coins.begin(); i != coins.end(); ++i)
		money = changeCoins(money,*i);

	std::cout << money*100 << " moeda(s) de R$ 0.01" << std::endl;

	return 0;
}

double changeNotes(double money, double value){
	int qtd = (int) (money/value);
	std::cout << qtd << " nota(s) de R$ " << std::fixed << std::setprecision(2) << value << std::endl;
	std::cout.unsetf (std::ios::fixed);
	return (money - qtd*value);
}

double changeCoins(double money, double value){
	int qtd = (int) (money/value);
	std::cout << qtd << " moeda(s) de R$ " << std::fixed << std::setprecision(2) << value << std::endl;
	std::cout.unsetf (std::ios::fixed); 
	return (money - qtd*value);
}