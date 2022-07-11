select [CategoriesName],[ProductsName]

from [dbo].[Products] p

Left join [dbo].[ProductssCategoriess] prc on p.[ProductsId] = prc.[ProductsId]

Left join [dbo].[Categories] c on c.[CategoriesId]= prc.[CategoriesId]
