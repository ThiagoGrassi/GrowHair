SCRIPT_START
{
LVAR_INT scplayer iDay currDay hair check
GET_PLAYER_CHAR 0 scplayer

loop:
REPEAT 3 hair
    check:
    WAIT 5000
    IF IS_PLAYER_WEARING 0 1 bald
        GET_INT_STAT 134 (iDay)
        iDay += 3
        WHILE currDay < iDay
            WAIT 0
            GET_INT_STAT 134 (currDay)
        ENDWHILE
        hair = 0
    ELSE
        IF IS_PLAYER_WEARING 0 1 player_face
            GET_INT_STAT 134 (iDay)
            iDay += 3
            WHILE currDay < iDay
                WAIT 0
                GET_INT_STAT 134 (currDay)
            ENDWHILE
            hair = 1
        ELSE
            IF IS_PLAYER_WEARING 0 1 flattop
                GET_INT_STAT 134 (iDay)
                iDay += 3
                WHILE currDay < iDay
                    WAIT 0
                    GET_INT_STAT 134 (currDay)
                ENDWHILE
                hair = 2
            ELSE
                GOTO check
            ENDIF
        ENDIF
    ENDIF
    SWITCH hair
        CASE 0
            GIVE_PLAYER_CLOTHES_OUTSIDE_SHOP 0 player_face head 1
            BREAK
        CASE 1
            GIVE_PLAYER_CLOTHES_OUTSIDE_SHOP 0 flattop flattop 1
            BREAK
        CASE 2
            GIVE_PLAYER_CLOTHES_OUTSIDE_SHOP 0 afro afro 1
            BREAK
    ENDSWITCH
    BUILD_PLAYER_MODEL 0
ENDREPEAT
GOTO loop
}
SCRIPT_END
