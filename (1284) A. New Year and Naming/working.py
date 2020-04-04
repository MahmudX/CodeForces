nm = input().split()
n = int(nm[0])
m = int(nm[1])
nList = input().split()
mList = input().split()
q = int(input())
for x in range(q):
    y = int(input())
    ny = y % n
    my = y % m
    print(nList[ny-1]+mList[my-1])
