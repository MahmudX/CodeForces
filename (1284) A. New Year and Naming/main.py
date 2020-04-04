s = "sin im gye gap eul byeong jeong mu gi gyeong".split()
t = "yu sul hae ja chuk in myo jin sa o mi sin".split()
slen = len(s)
tlen = len(t)
k = [1, 2, 3, 4, 10, 11, 12, 13, 73, 2016, 2017, 2018, 2019, 2020]
ans = ["sinyu", "imsul", "gyehae", "gapja", "gyeongo", "sinmi", "imsin",
       "gyeyu", "gyeyu", "byeongsin", "jeongyu", "musul", "gihae", "gyeongja"]
output = []
for y in k:
    ty = y % tlen
    sy = y % slen
    # print(slen)
    # print(s[sy-1]+t[ty-1])
    output.append(s[sy-1]+t[ty-1])
    # print(slen)
    # print(t[ty-1])
for x in range(len(output)):
    print("Output:", output[x])
    print("Ans:", ans[x])
    print()
