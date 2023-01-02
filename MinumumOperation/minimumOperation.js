let counter = 1
const findMinimumOperation = () => {
  return (number) => {
    const newNumber = multipleOfThree(number)
    if(newNumber === 1) return counter
    ++counter
    return findMinimumOperation()(newNumber)
  }
  
}

const multipleOfThree = (number) => {
  if(number === 1) return number
  const module = number % 3
  if (module === 0) return number / 3
  if (module === 1) return decreaseByOne(number)
  if (module === 2) return increaseByOne(number)
}

function closureCounter(get = false) {
  let counter = 1
  return function innerCounter() {
    if(get) return counter
    return ++counter
  }
}

const increaseByOne = (number) => number + 1
const decreaseByOne = (number) => number - 1

module.exports = findMinimumOperation;