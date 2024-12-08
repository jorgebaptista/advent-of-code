#include <bits/stdc++.h>
#include <algorithm>
using namespace std;

int main()
{
    ifstream fin("../test.txt");
    string s;
    int safe = 0;

    while (getline(fin, s))
    {
        stringstream lineStream(s);
        bool is_safe = true;
        int prev = 0;
        int current = 0;
        lineStream >> prev; // first number

        bool increasing = true;
        bool first = false;

        while (lineStream >> current)
        {
            if (!first)
            {
                first = true;
                if (current < prev)
                    increasing = false;
            }
            else if ((increasing && current < prev) || (!increasing && current > prev))
            {
                is_safe = false;
                break;
            }

            if (abs(prev - current) > 3 || abs(prev - current) < 1)
            {
                is_safe = false;
                break;
            }

            prev = current;
        }

        if (is_safe)
            safe++;
    }

    cout << safe;

    return 0;
}