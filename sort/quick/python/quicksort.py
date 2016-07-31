def quick_sort(arr):
    if(len(arr)<2):
        return arr
    
    pivot = arr[0]

    less = [i for i in arr[1:] if i <= pivot]
    greater = [i for i in arr[1:] if i > pivot]

    return quick_sort(greater) + [pivot] + quick_sort(less)

print quick_sort([5,7,82,3,54,67,32,45,11,-11])

