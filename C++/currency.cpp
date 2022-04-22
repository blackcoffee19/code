#include <iostream>

int main() {
  double pesos, reais, soles, dong, ndt;
  int num;
  double dollars;
  bool loop = true;
  while (loop) {
    std::cout << "Choose what you currency you want to change to dollar:\n";
    std::cout << "1. Pesos   2. Reais    3.Soles     4. VN dong    5.Ndt\n";
    std::cin >> num;
    switch (num) {
      case 1:
        std::cout << "Enter number of Colobian Pesos: ";
        std::cin >> pesos;
        break;
      case 2:
        std::cout << "Enter number of Colobian Reais: ";
        std::cin >> reais;
        break;
      case 3:
        std::cout << "Enter number of Colobian Soles: ";
        std::cin >> soles;
        break;
      case 4:
        std::cout << "Enter number of VietNam dong: ";
        std::cin >> dong;
        break;
      case 5:
        std::cout << "Enter number of China NDT: ";
        std::cin >> ndt;
        break;
      default:
        std::cout << "Total dollars:";
        loop = false;
        break;
    };
  }
  double pesos_dollar = 0.049;
  double reais_dollar = 0.21;
  double soles_dollar = 0.27;
  double dong_dollar = 0.000044;
  double ndt_dollar = 0.15;
  dollars = (pesos_dollar * pesos) + (reais_dollar * reais) + (soles_dollar*soles)+(dong_dollar*dong)+(ndt_dollar*ndt);
  std::cout << " $" << dollars << "\n";
  return 0;
}
