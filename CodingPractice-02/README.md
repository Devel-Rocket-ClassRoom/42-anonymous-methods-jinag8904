# 코딩 연습 - 익명 메서드 (2)

`Program.cs`에 아래 과제들의 코드를 순서대로 작성하세요.
모든 과제를 작성한 후 실행하면 각 과제의 실행 결과가 순서대로 출력됩니다.

> 💡 변수 이름이 겹치는 경우 중괄호 `{ }`로 코드를 감싸면 각 블록에서 같은 이름을 사용할 수 있습니다.

---

## 1. 익명 메서드로 대리자 인스턴스 생성

`Calculator` 대리자(int를 받아 int를 반환)를 선언하세요. 
`delegate (int x) { return x * x; }`로 익명 메서드를 할당하고, `calc(5)`를 출력하세요.

**실행 결과**

```
25
```

---

## 2. 기본 캡처

`int factor = 3`을 선언하고, `Func<int, int> multiplier`에 
`delegate (int n) { return n * factor; }` 익명 메서드를 할당하세요. 
`multiplier(10)`을 출력하세요.

**실행 결과**

```
30
```

---

## 3. 캡처된 변수의 변경

`int factor = 2`를 선언하고, `Func<int, int> multiplier`에 
`delegate (int n) { return n * factor; }` 익명 메서드를 할당하세요. 
`"factor = 2일 때: {multiplier(5)}"`를 출력한 후, `factor`를 10으로 변경하고 
`"factor = 10일 때: {multiplier(5)}"`를 출력하세요.

**실행 결과**

```
factor = 2일 때: 10
factor = 10일 때: 50
```

---

## 4. 익명 메서드 내부에서 외부 변수 수정

`int counter = 0`을 선언하고, `Action increment`에 매개변수를 생략한 익명 메서드를 
할당하세요. 이 메서드는 `counter++` 후 `"현재 카운터: {counter}"`를 출력합니다. 
`increment()`를 3번 호출한 후 `"최종 카운터: {counter}"`를 출력하세요.

**실행 결과**

```
현재 카운터: 1
현재 카운터: 2
현재 카운터: 3
최종 카운터: 3
```

---

## 5. 클로저 활용: 상태 유지

`CreateCounter()` 정적 메서드를 구현하세요. 내부에 `int count = 0`을 선언하고, 
매개변수를 생략한 익명 메서드로 `count++` 후 `count`를 반환하는 `Func<int>`를 반환합니다. 
`counter1`과 `counter2` 두 개의 독립적인 카운터를 만들어 `counter1`을 3번, 
`counter2`를 2번 호출하여 `"counter1: {값}"`, `"counter2: {값}"` 형식으로 출력하세요.

**실행 결과**

```
counter1: 1
counter1: 2
counter1: 3
counter2: 1
counter2: 2
```
