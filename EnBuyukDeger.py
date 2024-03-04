def max_(x):
    enBüyük = x[0]

    for i in x:
        if i > enBüyük:
            enBüyük = i
    return enBüyük

s1 = int(input("1. sayı : "))
s2 = int(input("2. sayı : "))
s3 = int(input("3. sayı : "))

list = [s1,s2,s3]
print("En büyük sayı : " + str(max_(list)))