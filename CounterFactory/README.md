# 카운터 팩토리

클로저를 활용하여 다양한 종류의 카운터를 생성하는 `CounterFactory` 클래스를 작성하시오.

**요구사항**

1. `CounterFactory` 클래스를 생성하고 다음 정적 메서드들을 구현함:
   - `CreateSimpleCounter()`: 1씩 증가하는 카운터를 반환함 (`Func<int>`)
   - `CreateStepCounter(int step)`: 지정된 step만큼 증가하는 카운터를 반환함
	(`Func<int>`)
	- `CreateBoundedCounter(int min, int max)`: min부터 max까지 순환하는 카운터를 반환함 
		- (`Func<int>`)
   
	- - `CreateResettableCounter()`: 증가 및 리셋 기능이 있는 카운터를 반환함
		- (`Action`과 `Func<int>`를 out 매개변수로 반환)

2. 각 메서드는 익명 메서드를 사용하여 클로저를 형성해야 함
 
3. `Main` 메서드에서 각 카운터를 테스트함:
   - 단순 카운터: 5번 호출
   - 스텝 카운터 (step=3): 4번 호출
   - 범위 카운터 (1~3): 7번 호출
   - 리셋 가능 카운터: 3번 호출 → 리셋 → 2번 호출

## 예상 실행 결과

```
=== 단순 카운터 ===
1 2 3 4 5

=== 스텝 카운터 (step=3) ===
3 6 9 12

=== 범위 카운터 (1~3) ===
1 2 3 1 2 3 1

=== 리셋 가능 카운터 ===
호출: 1 2 3
리셋 후: 1 2
```
