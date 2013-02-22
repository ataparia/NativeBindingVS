all:
	make -C "./Foo"
	cp "./Foo/libFooiOS.a" "./BindingFoo/BindingFoo/libFooiOS.a"

clean:
	rm -f "./BindingFoo/BindingFoo/*.a"