#include <iostream>
using namespace std;

int max_(int x[], int size) {
    int enBuyuk = x[0];

    for (int i = 1; i < size; ++i) {
        if (x[i] > enBuyuk) {
            enBuyuk = x[i];
        }
    }

    return enBuyuk;
}

int main() {
    int s1, s2, s3;

    cout << "1. sayı : ";
    cin >> s1;

    cout << "2. sayı : ";
    cin >> s2;

    cout << "3. sayı : ";
    cin >> s3;

    int list[] = {s1, s2, s3};
    int size = sizeof(list) / sizeof(list[0]);

    int result = max_(list, size);

    cout << "En büyük sayı: " << result << std::endl;

    return 0;
}
