import { useEffect, useState } from "react";

function App() {
    const [products, setProducts] = useState([
        { name: "product1", price: 200 },
        { name: "product2", price: 142 },
       
    ])

    //useEffect()

    function addProduct() {
        setProducts(prevState => [...prevState, { name: "product " + (prevState.length + 1), price: (prevState.length * 100) + 100 }])
    }
  return (
      <div >
          <h1>Jstore
          </h1>
          <ul>
              {products.map((item, index) => (
                  <li key={index}> {item.name} - {item.price}</li>
                  ))}
          </ul>
          <button onClick={addProduct}>
              Add Product

          </button>
    </div>
  );
}

export default App;
