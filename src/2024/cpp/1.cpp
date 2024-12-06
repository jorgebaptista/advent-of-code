#include <bits/stdc++.h>
#include <algorithm>
using namespace std;

int main()
{
    ifstream fin("../input1.txt");
    string s;
    vector<int> left, right;

    while (getline(fin, s))
    {
        stringstream lineStream(s);
        int l, r;
        lineStream >> l >> r;
        left.push_back(l);
        right.push_back(r);
    }

    
    sort(left.begin(), left.end());
    sort(right.begin(), right.end());

    int sum = 0;

    for (int i = 0; i < left.size(); i++)
    {
        int inner = abs(left[i] - right[i]);
        sum += inner;         
    }

    cout << sum << endl;

    multiset<int> right_set(right.begin(), right.end());

    sum = 0;

    for (int i = 0; i < left.size(); i++)
    {
        int inner = left[i] * right_set.count(left[i]);
        sum += inner;
    }

    cout << sum;

    return 0;
}