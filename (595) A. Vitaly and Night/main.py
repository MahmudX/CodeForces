nm = input().split()
counter = 0
for x in range(int(nm[0])):
    n = list(map(int, input().split()))
    for x in range(0, int(nm[1])*2, 2):
        if n[x] + n[x+1] > 0:
            counter += 1
print(counter)
