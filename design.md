Core concepts
=============

- 64-bit only
- 100% managed code
- Single address space
- Security model
	- Memory safety ensured by compiler
	- Processes have an associated user token and a capabilities token
		- User token is used for filesystem access and such
		- Capabilities governs service, intrinsic, and unsafe memory access
- Services are registered and accessed by interface

Kernel
======

- Set up memory
- Manage service access
- Start bootstrap service

Services
========

Built-ins
---------

- Bootstrap
	- Starts all other built-ins
	- Loads and runs externals
- Interrupt manager
- Core drivers
	- Video (temporary)
	- Storage (for boot device)
- Console
- VFS -- Manages filesystem services
	- ext2
- Loader -- Loads and runs external binaries

External
--------

- Drivers
	- PCI core
	- Video
	- NIC
	- Keyboard
	- Mouse
- Network manager
- Process manager
	- Thread manager inside of this?
- Display manager
