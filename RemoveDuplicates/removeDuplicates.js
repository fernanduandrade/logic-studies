export default filtrarArray(array) {
    return array.filter((duplicatos, index) => array.indexOf(duplicatos) === index);
}
