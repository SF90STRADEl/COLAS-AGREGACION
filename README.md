Sistema de Gestión de Clientes
Este es un programita en C# que maneja una cola de clientes. Básicamente, agrega clientes a una lista, atiende al primero que llega y te muestra cómo va la cola.

Qué hace
Usa una cola circular para manejar los clientes.
Los clientes se agregan al final y se atienden por orden (FIFO).
Puedes agregar clientes, atenderlos o ver la cola de espera.
Opciones
Agregar cliente: Escribe el nombre de un cliente y lo metes a la cola.
Atender cliente: Atiendes al primero que está en la cola.
Ver cola: Te muestra quién está esperando.
Salir: Terminas el programa.
Requisitos
Necesitas tener .NET instalado (versión 6.0 o más reciente).
Puedes usar Visual Studio o lo que sea que prefieras.
Cómo usarlo
Clona el repositorio:

bash
Copiar
Editar
git clone https://github.com/tu-usuario/sistema-gestion-clientes.git
Ve a la carpeta del proyecto:

bash
Copiar
Editar
cd sistema-gestion-clientes
Abre el proyecto y corre el programa.

Ejemplo
El programa te va a mostrar algo como esto:

markdown
Copiar
Editar
=== Sistema de Gestión de Atención al Cliente ===
1. Agregar cliente a la cola
2. Atender siguiente cliente
3. Salir del sistema
Seleccione opción: 1
Ingrese nombre del cliente: Juan Pérez
Cliente 'Juan Pérez' agregado a la cola.

[ESTADO DE LA COLA]
1. Juan Pérez
Clientes en espera: 1
