include $(top_srcdir)/build.rules.docklets.mk

ASSEMBLY = HelloWorld

FILES = \
	src/HelloWorldItemProvider.cs

RESOURCES = \
	    Resources/HelloWorld.addin.xml

PROJECT_REFERENCES = \
		     Docky.CairoHelper \
		     Docky.Items \
		     Docky.Services


REFERENCES = \
	     System \
	     System.Core \
	     Mono.Posix \
	     $(MONO_CAIRO_LIBS) \
	     $(DBUS_SHARP_10_LIBS) \
	     $(GTK_SHARP_20_LIBS)
