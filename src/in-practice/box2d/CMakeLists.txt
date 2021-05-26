include_directories( ../../../deps/box2d/include )

set(SOURCE_FILES 
main.cpp 
../../glad.c) 

add_executable(box2d-01 ${SOURCE_FILES})


target_link_libraries(box2d-01 
PUBLIC 
${COMMON_LIBS})
target_link_libraries(box2d-01 PRIVATE Box2D)