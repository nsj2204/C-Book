namespace DulAlgorithm
{
    public class Algorithm
    {
        /// <summary>
        /// 정렬 알고리즘(Sort Algorithm): 가장 [작은|큰] 데이터를 왼쪽으로 순서대로 이동
        /// </summary>
        /// <param name="numbers">정수형 배열</param>
        /// <returns>오름차순 정렬된 정수형 배열</returns>
        public static int[] SelectionSort(int[] numbers)
        {
            //[1] Input: Data Structure(Array, List, Stack, Queue, Tree, DB, ...)
            int N = numbers.Length; // 의사코드(슈도코드) 형태로 알고리즘을 표현하기 위함

            //[2] Process: Selection Sort(선택 정렬) 알고리즘
            for (int i = 0; i < N - 1; i++) // i = 0 to N - 1
            {
                for (int j = i + 1; j < N; j++) // j = i + 1 to N
                {
                    if (numbers[i] > numbers[j]) // 부등호 방향: 오름차순(>), 내림차순(<)
                    {
                        int temp = numbers[i]; numbers[i] = numbers[j]; numbers[j] = temp; // SWAP
                    }
                }
            }
            //[3] Output
            return numbers;
        }
    }
}
