import numpy as np,time
import math
from datetime import timedelta

def cotangent(x):
    try:
        return 1 / math.tan(x)
    except ZeroDivisionError:
        return 0 

sum = 0
while True:
    n = int(input("Enter an integer: "))
    if n>0:
        break
    print("Wrong input")
start=time.perf_counter()
for i in range(n):
    a = pow(10,-12)*(cotangent(i-5))+0.8*np.cos(5*i+2)
    sum=sum+a
    i+=1
end=timedelta(seconds=time.perf_counter()-start)
print("Sum =","",round(sum,2))
print("Time:","", end)