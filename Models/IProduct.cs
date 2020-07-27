using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopIT.Models
{
    // TODO
    // Clase madre del cual heredan los productos que se venden en floristeria
    // 1 Floristeria, 2 ARBOL, 3 FLORES, 4 Decoración que consta de Materiales de madera o de plastico. 
    // propiedad general. Todos los productos tienen un precio
    // crear menu donde el user esoga si desea crear floristeria, añadir productos o ver el stock. 
    // crear un diagrama de flujo de gen my model
    // crear carpeta controllar que se encargara de metodos de añadir elementos a listas

        // ALT+F8  para indentar 
        // CTR+k, CTR+C para comentar
    public interface IProduct
    {
        float Price { get; set; }
    }
}
