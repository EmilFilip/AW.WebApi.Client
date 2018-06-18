1.	Produce a web app that exposes data from the product, product-category and product-subcategory endpoints from the AW.WepApi repository and enables manipulation of product data.

2.	The web app should contain a page to display a list/grid of products, filtered by product-subcategory, which in turn should be          filtered by product-category. An example of such a UI is shown below
    a.	The page initially starts with a populated dropdown of all the (product) categories
    b.	Upon selection of a category, the sub category dropdown is populated with all subcategories pertaining to the chosen category
    c.	Upon selection of a subcategory, the product grid/table is populated with all products pertaining to the chosen subcategory
    d.	The action ‘Update’ redirects the page to an ‘Update Product’ page.
    e.	The action ‘Delete’ deleted the product

3.	The web app should have the ability to create products, update products and delete products. For the purposes of this test, creating and updating a product should be a separate page than the grid. With form fields allowing the setting of the product details: Key, Subcategory Id, Name, Stock Level and List Price.

4.	Deletion of a product should be confirmed via a modal window.
