
set(SOURCE_FILES 
    main.cpp 
    ../../glad.c 
    ../../../deps/imgui/backends/imgui_impl_opengl3.cpp 
    ../../../deps/imgui/backends/imgui_impl_glfw.cpp
    ../../../deps/imgui/imgui.cpp
    ../../../deps/imgui/imgui_draw.cpp
    ../../../deps/imgui/imgui_tables.cpp 
    ../../../deps/imgui/imgui_widgets.cpp 
    ../../../deps/imgui/imgui_demo.cpp) 

add_executable(imgui ${SOURCE_FILES})


target_link_libraries(imgui 
    PUBLIC 
    ${COMMON_LIBS})
