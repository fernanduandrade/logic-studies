const filtrarArray = array => array.filter((duplicatos, index) => array.indexOf(duplicatos) === index);

module.exports = filtrarArray;
