def find_biggest_index(arr):
    biggest = arr[0]
    biggest_index = 0
    
    for i in range(1,len(arr)):
        if(arr[i]>biggest):
            biggest = arr[i]
            biggest_index = i
    return biggest_index    

def selection_sort(unsorted):
    sorted = []
    for i in range(len(unsorted)):
        biggestIndex = find_biggest_index(unsorted)
        sorted.append(unsorted.pop(biggestIndex))
    return sorted

print selection_sort([5,7,82,3,54,67,32,45,11,-11])