#include <stdio.h>

int binary_search_shrinking_array(int value, int array[], int length){
  if(length == 1)
      return array[0] == value;

  //printf("\tArray [%d..%d]\n",array[0],array[length-1]);
  int half_length = length/2;
  int guess = array[half_length];
  //printf("\tguess %d\n",guess);
  if(guess == value)
    return 1;

  //printf("\thalf_length %d\n",half_length);

  if(guess<value){
    //guessed too low, take the upper half of the array
    array = array+half_length+1;
    //Check the upper limit of the array, this is plain C
    if(half_length == 2){
        half_length = 1;
    }
  }
  return binary_search_shrinking_array(value, array, half_length);
}

int binary_search(int value, int array[],int min_pos, int max_pos){
  if(min_pos > max_pos)
    return -1;

  int mid_pos = (min_pos + max_pos)/2;
  int guessed = array[mid_pos];
  if(guessed == value)
    return mid_pos;

  if(guessed < value)
  {
    //Recurse over upper half
    return binary_search(value, array, mid_pos+1, max_pos);
  } else {
    //Recurse over lower half
    return binary_search(value, array, min_pos, mid_pos-1);
  }
}

int main(int argc, char const *argv[]) {
  int array[] = {0,1,2,3,4,5,6,7,8};

  for(int i=-2; i<11; i++){
    printf("binary_search_shrinking_array %d: found %d\n", i, binary_search_shrinking_array(i, array,9));
  }

  for(int i=-2; i<11; i++){
    printf("binary_search %d: found %d\n", i, binary_search(i, array,0 ,9));
  }
}
