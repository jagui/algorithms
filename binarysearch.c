#include <stdio.h>

int binary_search(int value, int array[], int length){
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
  return binary_search(value, array, half_length);
}

int main(int argc, char const *argv[]) {
  /* code */
  int array[] = {0,1,2,3,4,5,6,7,8};
  for(int i=-2; i<11; i++){
    printf("binary_search %d: found %d\n", i, binary_search(i, array,9));
  }
}
