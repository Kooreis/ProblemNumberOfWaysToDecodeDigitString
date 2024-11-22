Here is a Python console application that solves the problem:

```python
def num_decodings(s):
    if not s:
        return 0

    n = len(s)
    dp = [0] * (n + 1)
    dp[0] = 1
    dp[1] = 1 if s[0] != '0' else 0

    for i in range(2, n + 1):
        if s[i - 1] != '0':
            dp[i] += dp[i - 1]
        if '10' <= s[i - 2:i] <= '26':
            dp[i] += dp[i - 2]
    return dp[n]

def main():
    s = input("Enter a digit string: ")
    print("Number of ways to decode the string: ", num_decodings(s))

if __name__ == "__main__":
    main()
```

This console application first asks the user to input a digit string. It then calculates the number of ways to decode the string and prints the result. The decoding is based on the assumption that '1' can be decoded as 'A', '2' as 'B', ..., '26' as 'Z'.