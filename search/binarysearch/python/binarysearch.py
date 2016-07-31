
def binary_search (value,arr,min_pos,max_pos):
    if(min_pos>=max_pos):
        return None
    
    mid_pos = (max_pos + min_pos) / 2

    if(arr[mid_pos] == value):
        return mid_pos

    if(arr[mid_pos]>value):
        return binary_search(value,arr,0,mid_pos-1)
    else:
        return binary_search(value,arr,mid_pos+1,len(arr))

print (binary_search(-1,[0,1,2,3,4,5,6,7],0,7))
print (binary_search(2,[0,1,2,3,4,5,6,7],0,7))
print (binary_search(7,[0,1,2,3,4,5,6,7],0,7))
print (binary_search(8,[0,1,2,3,4,5,6,7],0,7))
