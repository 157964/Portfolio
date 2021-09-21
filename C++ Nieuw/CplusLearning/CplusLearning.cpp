#include <iostream>
#include <list>
#include <chrono>
#include <ctime>
#include <future>

using namespace std;
using namespace chrono;

list<int> prime(int startingNumber, int cycles)
{
    list<int> primeArray;

    cycles += startingNumber;
    for (int i = startingNumber; i <= cycles; i++)
    {
        int flag = 0;

        int m = i / 2;
        for (int j = 2; j <= m; j++)
        {
            if (i % j == 0)
            {
                flag = 1;
                break;
            }
        }
        if (flag == 0)
        {
            primeArray.push_back(i);
        }
    }
    if (primeArray.front() == 0)
    {
        primeArray.pop_front();
        primeArray.remove(1);
    }
    return primeArray;
}

void calc() 
{
    try
    {
        cout << "how many itterations: ";
        int it;
        cin >> it;

        auto start = system_clock::now();
        future<list<int>> AwaitPrime = async(prime, 0, it);

        list<int> totalPrime = AwaitPrime.get();

        auto end = system_clock::now();

        duration<double> elapsed_seconds = end - start;
        time_t end_time = system_clock::to_time_t(end);

        for (int i : totalPrime)
        {
            cout << " " << i;
        }

        int totalCount = size(totalPrime);

        cout << "\nfound " << totalCount << " times prime\n";
        cout << "elapsed time: " << elapsed_seconds.count() << "s";

    }
    catch (exception e)
    {
        cout << "program has encountered error: ";
        throw e;
    }
}

int main()
{
    calc();
    return 0;
}
