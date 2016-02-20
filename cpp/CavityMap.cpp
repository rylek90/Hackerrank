#include <iostream>
#include <sstream>
//https://www.hackerrank.com/challenges/cavity-map/leaderboard
using namespace std;

int N;
u_long GridSize;

int main() {

    scanf("%d\n", &N);
    GridSize = N*N;

    string grid = "";
    string tmp;

    ostringstream strStream;
    for (int i = 0; i < N; i += 1) {
        cin >> tmp;
        strStream << tmp;
    }

    grid = strStream.str();

    if (GridSize == 1) {
        printf("%c", grid[0]);
        return 0;
    }

    for (int i = 0; i < N; i+=1) {
        printf("%c", grid[i]);
    }

    printf("\n");

    for (u_long i = N; i < GridSize - N; i += 1) {
        if (i % N == 0) {
            printf("%c", grid[i]);
            continue;
        }

        if ((u_long)(N - 1) == i % N) {
            printf("%c\n", grid[i]);
            continue;
        }

        if (grid[i] > grid[i - N] && grid[i] > grid[i + N] && grid[i] > grid[i-1] && grid[i] > grid[i+1]) {
            printf("X");
        } else {
            printf("%c", grid[i]);
        }
    }

    for (u_long i = GridSize - N; i < GridSize; i+=1) {
        printf("%c", grid[i]);
    }
    printf("\n");

    return 0;
}