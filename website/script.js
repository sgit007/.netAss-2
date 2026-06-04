const searchForm = document.querySelector('#searchForm');
const searchInput = document.querySelector('#productSearch');
const products = Array.from(document.querySelectorAll('.product-card'));

searchForm.addEventListener('submit', (event) => {
  event.preventDefault();
  const query = searchInput.value.trim().toLowerCase();

  products.forEach((product) => {
    const searchableText = `${product.textContent} ${product.dataset.keywords}`.toLowerCase();
    product.hidden = Boolean(query) && !searchableText.includes(query);
  });

  document.querySelector('#bestsellers').scrollIntoView({ behavior: 'smooth', block: 'start' });
});
